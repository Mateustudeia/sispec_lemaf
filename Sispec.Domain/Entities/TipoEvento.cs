﻿using System.Collections.Generic;

namespace Sispec.Domain.Entities
{
    public class TipoEvento : BaseEntity
    {
        public string DescricaoTipo { get; set; }

        public virtual IList<Evento> Evento { get; set; }
    };
}