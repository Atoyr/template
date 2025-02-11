    /// <summary>
    /// GET
    /// </summary>
    /// <returns>実行結果</returns>
    [HttpGet()]
    [Route("[controller]/[action]")]
    [ProducesResponseType<object>(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult<string> {{_input_:action_name}}()
    {
        return Ok();
    }