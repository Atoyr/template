        return StatusCode(
            StatusCodes.Status500InternalServerError, 
            new { Message = "内部サーバーエラーが発生しました。", Details = ex.Message }
        );