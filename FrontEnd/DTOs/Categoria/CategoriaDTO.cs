﻿using System.ComponentModel.DataAnnotations;

namespace FrontEnd.DTOs.Categoria
{
    public class CategoriaDTO
    {
    
        public int Id { get; set; }
    
        public string Nombre { get; set; }

        public bool Estado { get; set; }
    }
}