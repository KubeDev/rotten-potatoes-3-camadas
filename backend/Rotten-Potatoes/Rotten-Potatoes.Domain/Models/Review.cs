using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotten_Potatoes.Domain.Models
{
    public class Review
    {
        public Review()
        {
        }
        public int ReviewId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int FilmeId { get; set; }

    }
}
