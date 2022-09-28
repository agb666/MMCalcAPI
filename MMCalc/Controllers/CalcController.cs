using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MMCalc.Model;
using MMCalc.Repos;


namespace MMCalc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalcController : ControllerBase
    {
        private readonly ICalc _calc;
        private readonly ILogger<CalcController> _logger;

        public CalcController(ILogger<CalcController> logger, ICalc calc)
        {
            _logger = logger;
            _calc = calc;
        }

        [HttpPost]
        [Route("add")]
        public ActionResult CalcAdd(Calculation calc)
        {

            Result res = new Result();
            res.Value = _calc.Add(calc.Value1, calc.Value2);

            return Ok(res);
        }

        [HttpPost]
        [Route("subtract")]
        public ActionResult CalcSub(Calculation calc)
        {

            Result res = new Result();
            res.Value = _calc.Subtract(calc.Value1, calc.Value2);

            return Ok(res);
        }


        [HttpPost]
        [Route("multiply")]
        public ActionResult CalcMultiply(Calculation calc)
        {

            Result res = new Result();
            res.Value = _calc.Multiply(calc.Value1, calc.Value2);

            return Ok(res);
        }


        [HttpPost]
        [Route("divide")]
        public ActionResult CalcDivide(Calculation calc)
        {

            Result res = new Result();
            res.Value = _calc.Divide(calc.Value1, calc.Value2);

            return Ok(res);
        }



        [HttpGet]
        [Route("test")]
        public ActionResult test(Calculation calc)
        {

            return Ok("OK");
        }
    }
}
