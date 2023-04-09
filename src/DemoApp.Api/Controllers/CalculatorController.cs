namespace DemoApp.Api.Controllers;

using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("calculator")]
public class CalculatorController : ControllerBase
{
    [HttpGet("add")]
    public ActionResult<int> Add(int a, int b) => Ok(Calculator.Add(a, b));

    [HttpGet("subtract")]
    public ActionResult<int> Subtract(int a, int b) => Ok(Calculator.Subtract(a, b));

    [HttpGet("multiply")]
    public ActionResult<int> Multiply(int a, int b) => Ok(Calculator.Multiply(a, b));

    [HttpGet("divide")]
    public ActionResult<int> Divide(int a, int b)
    {
        try
        {
            return Ok(Calculator.Divide(a, b));
        }
        catch (DivideByZeroException ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
