using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ASP.NET_Learn.models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Richard";
        public int HtPoint { get; set; } = 100;
        public int Strength { get; set; } = 10;
        public int Defense { get; set; } = 10;
        public int Intelligence { get; set; } = 10;

        public RpgClass Class { get; set; } = RpgClass.Knight;

        internal static void Add(Character newCharacter)
        {
            throw new NotImplementedException();
        }
    }
}