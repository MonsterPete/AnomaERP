using Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAO
{
    public class PersonalFactorsDAO : IDAORepository<PersonalFactorsEntity>
    {
        public List<PersonalFactorsEntity> GetDataAll()
        {
            throw new NotImplementedException();
        }

        public List<PersonalFactorsEntity> GetDataByCondition(PersonalFactorsEntity entity)
        {
            throw new NotImplementedException();
        }

        public List<PersonalFactorsEntity> GetDataByCondition(PersonalFactorsEntity entity, int Index)
        {
            throw new NotImplementedException();
        }

        public PersonalFactorsEntity GetDataByID(long id)
        {
            throw new NotImplementedException();
        }

        public int InsertData(PersonalFactorsEntity entity)
        {
            throw new NotImplementedException();
        }

        public int UpdateData(PersonalFactorsEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
