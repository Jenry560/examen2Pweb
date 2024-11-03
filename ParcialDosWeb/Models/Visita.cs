using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ParcialDosWeb.Models;

public partial class Visita
{
    public int VisitaId { get; set; }
    [Required]
    public string? Telefono { get; set; } = string.Empty;
    [Required]
    public string? Nombre { get; set; } = string.Empty;
    [Required]
    public string? Apellido { get; set; } = string.Empty;
    [Required]
    public string? Correo { get; set; } = string.Empty;
}
