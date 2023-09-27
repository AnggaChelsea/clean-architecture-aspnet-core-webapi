using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SystemSchoolV1.Contracts.Authentication;
using SystemSchoolV1.Contracts.Kelas;

namespace SystemSchoolV1.Api.Controllers
{
    [ApiController]
    [Route("api/kelas")]
    public class KelasController : ControllerBase
    {

        [HttpPost("create-kelas")]
        public IActionResult CreateKelas(Contracts.Authentication.KelasRequest kelasRequest){
            // var body = _kelasService.CreateKelas(
            //     kelasRequest.NamaKelas,
            //     kelasRequest.JamBuka,
            //     kelasRequest.JamTutup
            // );
            // var response = new KelasReponse(
            //     id: Guid.NewGuid(),
            //     NamaKelas: body.NamaKelas,
            //     JamBuka: body.JamBuka,
            //     JamTutup : body.JamTutup
            // );
          return  Ok();
        }
        [HttpGet("get-kelas")]
        public IActionResult GetKelas(KelasReponse kelasReponse)
        {
            // var kelasFromService = _kelasService.GetAllKelas();
            return Ok();
        }
    }
}