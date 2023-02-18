using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.JsonPatch;
using Sec_master_api.Model;
using Microsoft.EntityFrameworkCore;

namespace Sec_master_api.Controllers;

[ApiController]
[Route("Equitycontroller")]
public class EquityController : ControllerBase
{
    

    private readonly SecMaster_AAContext _AAContext;

    public EquityController(SecMaster_AAContext secMaster_AAContext)
    {
        _AAContext = secMaster_AAContext;
    }

    [HttpGet(Name = "EquityController")]
    public IActionResult GetAll()
    {
        var equityDetails = this._AAContext.Equities.ToList();
        return Ok(equityDetails);
    }


     [HttpGet("GetByName/{equityName}")]
    public IActionResult GetByName(string equityName)
    {
        
        // Console.WriteLine(bondName);
        string outputString = equityName.Replace("%2F", "/");
        var equityDetails = this._AAContext.Equities.Where(b => b.SecurityName.ToLower().Contains(outputString.ToLower())).ToList();
        Console.WriteLine(equityName);
        return Ok(equityDetails);
    }

    [HttpDelete("remove")]

    public IActionResult DeleteEquity(string equityName)
    {
        string outputString = equityName.Replace("%2F", "/");
        var equityDetails = this._AAContext.Equities.Where(b => b.SecurityName.ToLower().Contains(outputString.ToLower())).ToList();
        if(equityDetails != null)
        {
            this._AAContext.Remove(equityDetails.FirstOrDefault());
            this._AAContext.SaveChanges();
            return Ok(true);
        }
        return Ok(false);

    }

    [HttpPost("create")]

    public IActionResult Create([FromBody] Equity _equity)
    {
        var equityDetails = this._AAContext.Equities.Where(b => b.Sid == _equity.Sid).FirstOrDefault();
        if(equityDetails != null)
        {
            return Ok("Already exists");
        }
        else
        {
            this._AAContext.Equities.Add(_equity);
            this._AAContext.SaveChanges();
            
        }
        return Ok("Inserted");
    }

    [HttpPatch("UpdateEquity/{securityId}")]
    public IActionResult UpdateEquity([FromBody] JsonPatchDocument equityModel ,[FromRoute] int securityId){
        var equity = _AAContext.Equities.Find(securityId);
        equityModel.ApplyTo(equity);
        _AAContext.SaveChanges();
        return Ok(equity);
    }


    [HttpPut("UpdateEquity/{securityId}")]
     public IActionResult UpdateEquity([FromRoute]int securityId , [FromBody]Equity equityModel)
    {
        if(securityId != equityModel.Sid){
            return Ok("Record not found");
        }
        _AAContext.Entry(equityModel).State = EntityState.Modified; //means we are trying to update the state of a particular employee.
        try{
            _AAContext.SaveChanges();
        }catch(DbUpdateConcurrencyException){
            throw;
        }
        return Ok(true);
    }


}
