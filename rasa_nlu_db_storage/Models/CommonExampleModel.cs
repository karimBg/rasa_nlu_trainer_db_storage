﻿using Newtonsoft.Json;
using rasa_nlu_storage.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rasa_nlu_db_storage.Models
{
    public class CommonExampleModel
    {
        [Display(Name = "text")]
        [JsonProperty("text")]
        public string Text { get; set; }

        [Display(Name = "intent")]
        [JsonProperty("intent")]
        public string Intent { get; set; }

        [Display(Name = "entities")]
        [JsonProperty("entities")]
        public ICollection<EntityModel> Entities { get; set; }
    }
}
