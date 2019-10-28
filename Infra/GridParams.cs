using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Http;

namespace ControleFinanceiro.Infra
{
    public class GridParams
    {
        public int Current { get; set; }
        public int rowCount { get; set; }
        public string SearchPhrase { get; set; }
        public string Id { get; set; }

        public CampoOrdenado ObterCampoOrdenado(HttpRequest request)
        {
            var dict = request.Form.ToDictionary(x => x.Key, x => x.Value.ToString());
            string campo = dict.Where(k => k.Key.StartsWith("sort[")).FirstOrDefault().Key;
            string ordenacao = dict.Where(k => k.Key.StartsWith("sort[")).FirstOrDefault().Value;
            // string campo = request.Form.Where(k => k.Key.StartsWith("sort[")).FirstOrDefault();
            // string ordenacao = request.Form[campo];
            ordenacao = ordenacao != null ? ordenacao : campo != null ? "" : "desc";
            campo = campo != null ? campo.TrimStart("sort[".ToCharArray()).TrimEnd(']') : "Id";
            return new CampoOrdenado() { Campo = campo, Ordem = ordenacao };
        }
    }

    public class CampoOrdenado
    {
        public string Campo { get; set; }
        public string Ordem { get; set; }
    }
}