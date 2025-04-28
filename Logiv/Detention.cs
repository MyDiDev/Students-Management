using Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Detention
    {
        public int idStudent;
        public string Reason;
        public string TypeDetention;
        public string State;
        public string Grade;
        public int DetentionNum;
        public DateTime Date;

        public Detention(int idStudent, string reason, string typeDetention, string state, string grade, int detentionNum, DateTime date)
        {
            this.idStudent = idStudent;
            Reason = reason;
            TypeDetention = typeDetention;
            State = state;
            Grade = grade;
            DetentionNum = detentionNum;
            Date = date;
        }

        public Detention() { }

        ~Detention() { }

        public bool NewDetention() => conn.addDetencion(this.idStudent, Reason, TypeDetention, State, Grade, DetentionNum, Date);
        public bool RemoveDetention(int id) => conn.delDetencion(id);
        public bool ModifyDetencion(int id) => conn.uptDetencion(id, idStudent, Reason, TypeDetention, State, Grade, DetentionNum, Date);
        public DataTable ConsultDetentions() => conn.consultDetencion();
    }
}
