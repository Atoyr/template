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