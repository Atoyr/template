    /// <summary>
    /// POST
    /// </summary>
    /// <returns>実行結果</returns>
    [HttpPost()]
    [Route("[controller]/[action]")]
    [ProducesResponseType<object>(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    [Consumes("application/json")]
    public IActionResult {{_input_:action_name}}(object obj)
    {
        try
        {
            {{_cursor_}}
        }
        catch (InvalidDataException)
        {
            return NotFound();
        }
        catch (Exception ex)
        {
            return StatusCode(
                    StatusCodes.Status500InternalServerError, 
                    new { Message = "内部サーバーエラーが発生しました。", Details = ex.Message }
                    );
        }
        return Ok(obj);
    }