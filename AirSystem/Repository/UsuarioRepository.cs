using AirSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirSystem.Repository
{
    class UsuarioRepository
    {
        private static List<Usuario> usuarios;

        private static int contador = 1;

        public UsuarioRepository()
        {
            if (usuarios == null)
            {
                usuarios = new List<Usuario>();

                usuarios.Add(new Usuario
                {
                    codigo = 1,
                    nome = "Lucas",
                    sobrenome = "Gonçalves",
                    endereco = "rua blbalbal",
                    usuario = "lucasryg",
                    senha = "123123",
                    numero = "123""
                }
                );
                contador++;
                usuarios.Add(new Usuario
                {
                    codigo = 1,
                    nome = "Joao",
                    sobrenome = "Santos",
                    endereco = "rua blbalbal",
                    usuario = "joaodev",
                    senha = "123123",
                    numero = "321"
                }
                );
                contador++;
            }
        }
      
        public List<Usuario> Listar()
        {
            return usuarios;
        }

        public void adicioanar(Usuario usuario)
        {
            usuario.codigo = contador;

            usuarios.Add(usuario);
            contador++;
        }

        public void alterar(Usuario usuario)
        {
            Usuario u = usuarios.Find(x => x.codigo == usuario.codigo);
            usuarios[usuarios.IndexOf(u)] = usuario;
        }

        public void deletar(int codigo)
        {
            Usuario u = usuarios.Find(x => x.codigo == codigo);
            usuarios.Remove(u);
        }
    }
}
