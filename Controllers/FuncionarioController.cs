using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using f12api.Database;
using LibsServer.Model;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace f12api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class FuncionariosController : ControllerBase
    {
        /// <summary>
        /// Consulta todos os Funcionários
        /// </summary>
        /// <remarks>Fantástico!</remarks>
        /// <param>Sem parâmetros</param>
        /// <response code="200">Funcionários encontrados</response>
        /// <response code="400">Funcionário não encontrado/Valores inválidos</response>
        /// <response code="500">Oops! Nao pude buscar os Funcionário neste momento</response>
        /// <returns>Lista de Funcionários</returns>
        [HttpGet]
        [ProducesResponseType(typeof(Funcionario), 200)]
        [ProducesResponseType(typeof(IDictionary<string, string>), 404)]
        [ProducesResponseType(500)]
        public async Task<ActionResult<List<Funcionario>>> Get([FromServices] DataContext context)
        {
            var funcionarios = await context.Funcionarios.ToListAsync();
            if(funcionarios == null)
            {
                return NotFound(
                    new {
                        msg = "Não foi encontrado resultados para o termo digitado",
                        error = true
                    }
                );
            }       
            return funcionarios;
        }

        /// <summary>
        /// Consulta Funcionário por ID
        /// </summary>
        /// <param name="id">ID do funcionário</param>
        /// <response code="200">Funcionário encontrado</response>
        /// <response code="404">Funcionário não encontrado/Valores inválidos</response>
        /// <response code="500">Oops! Não pude buscar os Funcionário neste momento</response>
        /// <returns>Json Funcionário</returns>
        /// GET: api/Funcionario/5
        [ProducesResponseType(typeof(Funcionario), 200)]
        [ProducesResponseType(typeof(IDictionary<string, string>), 404)]
        [ProducesResponseType(500)]
        [HttpGet("{id:int}", Name = "Get")]
        public async Task<ActionResult<Funcionario>> GetById(
            [FromServices] DataContext context,
            int id)
        {
            var funcionario = await context.Funcionarios
            // .Include(x => x.Nome)
            // .AsNoTracking() //usar quando quuiser apenas jogar os dados na tela e não fazer alterações
            .FirstOrDefaultAsync(x => x.Id == id);

            if (funcionario == null)
                return NotFound(
                    new {
                        msg = "Não foi encontrado resultados para o termo digitado",
                        error = true
                    }
                );
            return new OkObjectResult(funcionario);
        }

        /// POST: api/Funcionario
        /// <summary>
        /// Salvar os dados
        /// </summary>
        /// <param name="context">Banco de dados -  Automático</param>
        /// <param name="model">Classe Funcionário - Automático</param>
        /// <returns></returns>
        [ProducesResponseType(typeof(Funcionario), 200)]
        [ProducesResponseType(typeof(IDictionary<string, string>), 404)]
        [ProducesResponseType(500)]
        [HttpPost]
        public async Task<ActionResult<Funcionario>> Post(
            [FromServices] DataContext context,
            [FromBody] Funcionario model)
        {
            if (ModelState.IsValid)
            {
                context.Funcionarios.Add(model);
                await context.SaveChangesAsync();

                return new OkObjectResult(model);
            }
            else
            {
                return NotFound(
                    new {
                        msg = "Erro ao fazer Post",
                        error = true
                    }
                );
            }
        }

        /// ATUALIZAR
        /// PUT: api/Funcionario/5
        /// <summary>
        /// Atualizar os dados
        /// </summary>
        /// <param name="id">Obrigatório. Id para salvar</param>
        /// <param name="context">Banco de dados -  Automático</param>
        /// <param name="model">Classe Funcionário - Automático</param>
        /// <returns></returns>
        [ProducesResponseType(typeof(Funcionario), 200)]
        [ProducesResponseType(typeof(IDictionary<string, string>), 406)]
        [ProducesResponseType(500)]
        [HttpPut("{id:int}", Name = "Put")]
        public async Task<ActionResult<Funcionario>> Put (     
            [FromServices] DataContext context,
            [FromBody]Funcionario model,
            int id

        )
        {
            if (id != model.Id)
                return NotFound("Erro 1");

            if (ModelState.IsValid){
               context.Update(model);
               await context.SaveChangesAsync();               
               return new OkObjectResult(model);
            
            } else {
                return NotFound("Erro 2");
            }            
        }

        // DELETE: api/Funcionario/5
        [ProducesResponseType(typeof(Funcionario), 202)]
        [ProducesResponseType(typeof(IDictionary<string, string>), 404)]
        [ProducesResponseType(500)]
        [HttpDelete("{_id:int}")]
        public async Task<IActionResult> Delete(
            int _id,
            [FromBody]Funcionario model,
            [FromServices] DataContext context)
        {
            var funcionarioFromDB = await context.Funcionarios.FirstAsync(x => x.Id == _id);
            if (funcionarioFromDB == null)
                return NotFound("Não foi possível encontrar o Funcionário por esse Id.");

            model = funcionarioFromDB;
            model.Ativo = !model.Ativo;

            context.Update(model);
            await context.SaveChangesAsync();

            return new OkResult();
        }
    }
}
