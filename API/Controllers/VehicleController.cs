using System;
using System.Threading.Tasks;
using API.Data;
using API.DTOs;
using API.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("/api/vehicles")]
  public class VehiclesController : Controller
  {
    private readonly IMapper mapper;
    private readonly DataContext context;

    public VehiclesController(IMapper mapper, DataContext context)
    { this.context = context;
      this.mapper = mapper;
    }

    [HttpPost]    //🛢
    public async Task<IActionResult> CreateVehicle([FromBody] VehicleDto vehicleDto)
    {
        if (!ModelState.IsValid)
          return BadRequest(ModelState);

var model= await context.Models.FindAsync(vehicleDto.ModelId);
if(model==null){
    ModelState.AddModelError("ModelId", "invalid modelId");
    return BadRequest(ModelState);
}

        var vehicle = mapper.Map<VehicleDto, Vehicle>(vehicleDto);
        vehicle.LastUpdate = DateTime.Now;

        context.Vehicles.Add(vehicle);
        await context.SaveChangesAsync();

        var result = mapper.Map<Vehicle, VehicleDto>(vehicle);

        return Ok(result);
    }
  
  
    [HttpPut("{id}")]     //🛢
    public async Task<IActionResult> UpdateVehicle(int id, [FromBody] VehicleDto vehicleDto)
    {
        if (!ModelState.IsValid)
          return BadRequest(ModelState);

          var model= await context.Models.FindAsync(vehicleDto.ModelId);
            if(model==null){
            ModelState.AddModelError("ModelId", "invalid modelId");
            return BadRequest(ModelState);
}

       var vehicle = await context.Vehicles.FindAsync(id);
     //     var vehicle = await context.Vehicles.Include(v => v.Features).SingleOrDefaultAsync(v => v.Id == id);
        mapper.Map<VehicleDto, Vehicle>(vehicleDto, vehicle);
        vehicle.LastUpdate = DateTime.Now;

        // context.Vehicles.Add(vehicle);
        await context.SaveChangesAsync();

        var result = mapper.Map<Vehicle, VehicleDto>(vehicle);

        return Ok(result);
    }
  }  
  
   
  }

