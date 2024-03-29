﻿using webAPI02.Infraestrutura.Dto.VendaDto;

namespace webAPI02.Infraestrutura.Dto.ClienteDto
{
    public class ReadClienteIdDto
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Cpf { get; set; }

        public DateTime DataNascimento { get; set; }

        public string Endereco { get; set; }
        public virtual ICollection<ReadVendaDto> Vendas { get; set; }
    }
}
