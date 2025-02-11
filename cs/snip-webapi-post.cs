    /// <summary>
    /// POST
    /// </summary>
    /// <returns>実行結果</returns>
    [HttpPost()]
    [Route("[controller]/[action]")]
    [ProducesResponseType<object>(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult {{_input_:action_name}}(object obj)
    {
        return Ok(obj);
    }