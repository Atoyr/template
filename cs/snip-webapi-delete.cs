    /// <summary>
    /// DELETE
    /// </summary>
    /// <returns>実行結果</returns>
    [HttpDelete()]
    [Route("[controller]/{id}")]
    [ProducesResponseType<CreateTaskModel>(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> Delete(string id)
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
        return Ok(new { status = "succsss"});
    }
