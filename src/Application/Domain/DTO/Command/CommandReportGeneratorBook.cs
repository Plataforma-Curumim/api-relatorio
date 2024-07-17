﻿using api_relatorio.Application.Domain.Entities;

namespace api_relatorio.Application.Domain.DTO.Command
{
    public record CommandReportGeneratorBook
    {
        public Book? Book{ get; set; }
        public string UserId { get; set; }
        public string? BookId { get; set; }
        public DateTime DateRegister { get; set; }
        public ConfigLibrary config { get; set; }
    }
}
