    /// <summary>
    /// GET
    /// </summary>
    /// <returns>実行結果</returns>
    [HttpGet()]
    [Route("[controller]/[action]")]
    [ProducesResponseType<object>(StatusCodes.Status200OK)]
    public IActionResult<string> {{_input_:action_name}}()
    {
        {{_cursor_}}
        return Ok();
    }