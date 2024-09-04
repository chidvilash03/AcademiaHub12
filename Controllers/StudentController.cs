using AcademiaHub.Models;
using AcademiaHub.Repositories;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class StudentController : ControllerBase
{
    private readonly IAcademiaHubRepository _studentRepository;

    public StudentController(IAcademiaHubRepository studentRepository)
    {
        _studentRepository = studentRepository;
    }

    [HttpGet]
    [Route("GetAllStudentDetails")]
    public IActionResult GetAllStudents()
    {
        var students = _studentRepository.GetAll();
        return Ok(students);
    }

    //[HttpGet("{id}")]
    //public IActionResult GetStudentById(int id)
    //{
    //    var student = _studentRepository.GetById(id);
    //    if (student == null) return NotFound();
    //    return Ok(student);
    //}

    //[HttpPost]
    //public IActionResult CreateStudent([FromBody] Student student)
    //{
    //    if (student == null) return BadRequest();
    //    _studentRepository.Insert(student);
    //    _studentRepository.Save();
    //    return CreatedAtAction(nameof(GetStudentById), new { id = student.EnrollmentNo }, student);
    //}

    //[HttpPut("{id}")]
    //public IActionResult UpdateStudent(int id, [FromBody] Student student)
    //{
    //    if (student == null || student.EnrollmentNo != id) return BadRequest();
    //    _studentRepository.Update(student);
    //    _studentRepository.Save();
    //    return NoContent();
    //}

    //[HttpDelete("{id}")]
    //public IActionResult DeleteStudent(int id)
    //{
    //    var student = _studentRepository.GetById(id);
    //    if (student == null) return NotFound();
    //    _studentRepository.Delete(id);
    //    _studentRepository.Save();
    //    return NoContent();
    //}
}
