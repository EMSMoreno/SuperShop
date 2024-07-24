﻿using System;
using System.ComponentModel.DataAnnotations;

namespace SuperShop.Data.Entities
{
    public class Product : IEntity
    {

        public int Id { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "The field {0} can contain {1} characters length.")]
        public string Name { get; set; }

        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal Price { get; set; }

        [Display(Name = "Image")]
        public string ImageUrl { get; set; }

        [Display(Name = "Last Purchase")]
        public DateTime? LastPurchase { get; set; }

        [Display(Name = "Last Sale")]
        public DateTime? LastSale { get; set; }

        [Display(Name = "Is Available")]
        public bool IsAvailable { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        public double Stock { get; set; }

        public User User { get; set; } //user que usa o produto

        public string ImageFullPath
        {
            get
            {
                if(string.IsNullOrEmpty(ImageUrl))
                {
                    return null;
                }

                return $"https://supershoptpsieduardom.azurewebsites.net{ImageUrl.Substring(1)}";
            }
        } //propriedade só de leitura; dá o caminho da imagem para aqueles que não vão aceder a base de dados
    }
}
