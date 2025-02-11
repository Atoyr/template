    /// <summary>
    /// PUT
    /// </summary>
    /// <returns>実行結果</returns>
    [HttpPut()]
    [Route("[controller]/{id}")]
    [ProducesResponseType<CreateTaskModel>(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    [Consumes("application/json")]
    public async Task<IActionResult> {{_input_:method_name}}( [FromRoute]  string id)
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
