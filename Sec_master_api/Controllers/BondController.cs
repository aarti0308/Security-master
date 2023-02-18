using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sec_master_api.Model;


namespace Sec_master_api.Controllers;

[ApiController]
[Route("Bondcontroller")]
public class BondController : ControllerBase
{
    

    private readonly SecMaster_AAContext _AAContext;

    public BondController(SecMaster_AAContext secMaster_AAContext)
    {
        _AAContext = secMaster_AAContext;
    }

    [HttpGet(Name = "BondController")]
    public IActionResult GetAll()
    {
        var bondDetails = this._AAContext.Bonds.ToList();
        return Ok(bondDetails);
    }

     [HttpGet("GetByName/{bondName}")]
    public IActionResult GetByName(string bondName)
    {
        
        // Console.WriteLine(bondName);
        string outputString = bondName.Replace("%2F", "/");
        var bondDetails = this._AAContext.Bonds.Where(b => b.SecurityName.ToLower().Contains(outputString.ToLower())).ToList();
        Console.WriteLine(bondName);
        return Ok(bondDetails);
    }


    [HttpDelete("remove")]

    public IActionResult DeleteBond(string bondName)
    {
        string outputString = bondName.Replace("%2F", "/");
        var bondDetails = this._AAContext.Bonds.Where(b => b.SecurityName.ToLower().Contains(outputString.ToLower())).ToList();
        if(bondDetails != null)
        {
            this._AAContext.Remove(bondDetails.FirstOrDefault());
            this._AAContext.SaveChanges();
            return Ok(true);
        }
        return Ok(false);

    }

    [HttpPost("create")]

    public IActionResult Create([FromBody] Bond _bond)
    {
        var bondDetails = this._AAContext.Bonds.Where(b => b.Sid == _bond.Sid).FirstOrDefault();
        if(bondDetails != null)
        {
            return Ok("Already exists");
        }
        else
        {
            this._AAContext.Bonds.Add(_bond);
            this._AAContext.SaveChanges();
            
        }
        return Ok("Inserted");
    }

     [HttpPost("update")]

    public IActionResult update([FromBody] Bond _bond)
    {
        var bondDetails = this._AAContext.Bonds.Where(b => b.Sid == _bond.Sid).FirstOrDefault();
        if(bondDetails != null)
        {
            bondDetails.SecurityName = _bond.SecurityName;
            bondDetails.SecurityDescription = _bond.SecurityDescription;
            this._AAContext.SaveChanges();
        }
        else
        {
            return Ok("Not found");
        }
        return Ok("Updated");
    }

     [HttpPatch("UpdateEquity/{securityId}")]
    public IActionResult UpdateEquity([FromBody] JsonPatchDocument bondModel ,[FromRoute] int securityId){
        var bond = _AAContext.Bonds.Find(securityId);
        bondModel.ApplyTo(bond);
        _AAContext.SaveChanges();
        return Ok(bond);
    }


    [HttpPut("UpdateBond/{securityId}")]
     public IActionResult UpdateBond([FromRoute]int securityId , [FromBody]Bond bondModel)
    {
        if(securityId != bondModel.Sid){
            return Ok("Record not found");
        }
        _AAContext.Entry(bondModel).State = EntityState.Modified; //means we are trying to update the state of a particular employee.
        try{
            _AAContext.SaveChanges();
        }catch(Microsoft.EntityFrameworkCore.DbUpdateConcurrencyException)
        {
            throw;
        }
        return Ok(true);
    }





}
