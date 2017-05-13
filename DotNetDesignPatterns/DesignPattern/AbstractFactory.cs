using System;
    public class AbstractFactory
    {
        public enum UISkillSet {  DotNet, Java };
        public enum DBSkillSet {  MSSQL, MySQL };

        /// <summary>
        /// Abstract Factory : 
        /// Provide an interface for creating families of related or dependent objects without 
        /// specifying their concrete classes
        /// </summary>
        /// <param name="args"></param>
        void Main(string[] args)
        {
            IBaseFactory baseFactory = new ProjectA(UISkillSet.DotNet, DBSkillSet.MSSQL);
            Console.WriteLine(baseFactory.GetUITeam().GetTeam());

            Console.ReadKey();
        }

        public interface IBaseFactory
        {
            ITeamFactory GetUITeam();
            ITeamFactory GetDBTeam();
        }

        public interface ITeamFactory
        {
            String GetTeam();
        }

        public class ProjectA : IBaseFactory
        {
            private readonly UISkillSet UISkillSet;
            private readonly DBSkillSet DBSkillSet;

            public ProjectA(UISkillSet UISkillSet, DBSkillSet DBSkillSet)
            {
                this.UISkillSet = UISkillSet;
                this.DBSkillSet = DBSkillSet;
            }
            public ITeamFactory GetUITeam()
            {
                switch (UISkillSet)
                {
                    case UISkillSet.DotNet:
                        return new DotNetTeam();
                    case UISkillSet.Java:
                        return new JavaTeam();
                    default:
                        throw new IndexOutOfRangeException();
                }
            }

            public ITeamFactory GetDBTeam()
            {
                throw new NotImplementedException();
            }
        }

        public class DotNetTeam : ITeamFactory
        {
            public string GetTeam()
            {
                return "DotNet Team";
            }
        }

        public class JavaTeam : ITeamFactory
        {
            public string GetTeam()
            {
                return "Java Team";
            }
        }
    }
