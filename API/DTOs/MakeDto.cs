
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{
   
    public class MakeDto
    {
        public int 
        Id { get; set; }


        public string
        Name { get; set; }
        
        public ICollection<ModelDto> 
        Models { get; set; }

        public MakeDto()
        {
            Models = new Collection<ModelDto>();
        }
    }
    }
