using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Stock
{
    public class UpdateStockRequestDto
    {
        [Required]
        [MinLength(5, ErrorMessage = "Symbol must have length > 5 character!!!")]
        [MaxLength(200, ErrorMessage = "Symbol must have maxlength <200!!!")]
        public string Symbol { get; set; } = string.Empty;
        [Required]
        [MinLength(5, ErrorMessage = "CompanyName must have length > 5 character!!!")]
        [MaxLength(200, ErrorMessage = "CompanyName must have maxlength <200!!!")]
        public string CompanyName { get; set; } = string.Empty;
        [Range(0,1000000000)]
        public decimal Purchase { get; set; }
        [Range(0,100)]
        public decimal LastDiv { get; set; }
        [Required]
        [MinLength(5, ErrorMessage = "Industry must have length > 5 character!!!")]
        [MaxLength(200, ErrorMessage = "Industry must have maxlength <200!!!")]
        public string Industry { get; set; } = string.Empty;
        [Range(0,100000000)]
        public long MarketCap { get; set; }
    }
}