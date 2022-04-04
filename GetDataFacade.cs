using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto21
{
    class GetDataFacade
    {
        private JSON_reader x { get; set; }

        public GetDataFacade()
        {
            x = JSON_reader.Instance;
        }
        //busca usuarios
        public User GetUser(string u)
        {
            foreach (User un in x.user.Data)
            {
                if (u == un.username)
                {
                    return un;
                }
            }

            return null;
        }

        public Subject GetSubject(int sid)
        {
            foreach (Subject sb in x.subject.Data)
            {
                if (sid == sb.subject_id)
                {
                    return sb;
                }
            }

            return null;
        }

        //regresar calificaciones por estudiante
        public List<Score> GetStudentScore(string u)
        {
            List<Score> grades = new List<Score>();
            foreach (Score sr in x.score.Data)
            {
                if (u == sr.student)
                {
                    grades.Add(sr);
                }
            }
            return grades;
        }

        //regresar calificaciones para maestro
        public List<Score> GetTeacherScore(string u)
        {
            List<Score> grades = new List<Score>();
            foreach (Score sr in x.score.Data)
            {
                Subject s = GetSubject(sr.subject_id);
                if (u == s.teacher)
                {
                    grades.Add(sr);
                }
            }
            return grades;
        }

        //validar contraseña
        public bool GetPass(string u, string p)
        {
            User un = GetUser(u);
            if (un.password == p)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
