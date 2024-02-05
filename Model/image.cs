﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalgueroRecuperacion.Model
{
    public class DogApiResponse
    {
        public List<string> Message { get; set; }
        public string Status { get; set; }
    }
    public class BreedListApiResponse
    {
        public Dictionary<string, List<string>> Message { get; set; }
        public string Status { get; set; }
    }

    public class DogImagesApiResponse
    {
        public string Message { get; set; }
        public string Status { get; set; }
    }


}
