using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShopCartAPI.Models {
    public class ProductDetail {
        [Key]
        public int IdProduto { get; set; }

        [Column(TypeName ="nvarchar(100)")]
        public string NomeProduto { get; set; }

        [Column(TypeName ="nvarchar(16)")]
        public string NumeroProduto { get; set; }

        [Column(TypeName ="nvarchar(5)")]
        public string DataLancamento { get; set; }
        
        [Column(TypeName ="nvarchar(100)")]
        public string PrecoProduto { get; set; }

    }
}
