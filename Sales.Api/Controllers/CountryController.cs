using MediatR;
using Microsoft.AspNetCore.Mvc;
using Sales.Api.Models;
using Sales.Api.Queries.CountryQuery.Get;
//using Sales.Api.Commands.CountryCommands.Add;

namespace Sales.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController(IMediator mediator) : ControllerBase
    {
        [HttpGet("[action]")]
        public async Task<ActionResult<List<CountryDto>>> GetAllCountries()
        {
            return Ok (await mediator.Send(new GetAllCountriesQuery()));
        }
        // GET: api/barcodes/id
        //[HttpGet("[action]")]
        //public async Task<ActionResult<BarcodeDto>> GetById(int id)
        //{
        //    return Ok(await mediator.Send(new GetBarcodeByIdQuery(id)));
        //}
        //POST: api/barcodes
        //[HttpPost("[action]")]
        //public async Task<ActionResult<BarcodeDto>> AddBarcodecommand([FromBody] CreateBarcodeRequest createrequest)
        //{
        //    return Ok(await mediator.Send(new AddBarcodecommand(createrequest)));
        //}
        //[HttpPut("[action]")]
        //[ProducesResponseType(StatusCodes.Status204NoContent)]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
        //public async Task<IActionResult> UpdateBarcodeByValue([FromBody] UpdateBarcodeByValueDto request)
        //{
        //    var command = new UpdateBarcodeByValuecommand
        //    {
        //        BarcodeValue = request.BarcodeValue,
        //        NewBarcodeValue = request.NewBarcodeValue
        //    };

        //    var result = await mediator.Send(command);
        //    return result ? NoContent() : NotFound();
        //}
        //    var wasFoundAndUpdated = await mediator.Send(command);

        //    if (!wasFoundAndUpdated)
        //    {
        //        return NotFound();
        //    }

        //    // According to REST standards, a successful PUT should return 204 No Content.
        //    return NoContent();
        //}

        //DELETE: api/barcodes/delete/5
        //[HttpDelete("Delete/{id}")]
        //public async Task<IActionResult> Delete(int id)
        //{
        //    var command = new DeleteAsync(id);
        //    var result = await mediator.Send(command);
        //    if (!result) return NotFound();
        //    return Ok();
        //}

    }
}
