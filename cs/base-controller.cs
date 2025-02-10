using Microsoft.AspNetCore.Mvc;

namespace {{_input:namespace}};

public class {{_input:controller_name}}Controller : ControllerBase
{
    /// <summary>
    /// GET
    /// </summary>
    /// <returns>実行結果</returns>
    [HttpGet()]
    [Route("[controller]/[action]")]
    [ProducesResponseType<object>(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult Index()
    {
        return Ok();
    }

    /// <summary>
    /// POST
    /// </summary>
    /// <returns>実行結果</returns>
    [HttpPost()]
    [Route("[controller]/[action]")]
    [ProducesResponseType<object>(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult CreateProduct(object obj)
    {
        return Ok(obj);
    }
}
