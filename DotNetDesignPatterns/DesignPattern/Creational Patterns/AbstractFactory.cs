using System;

namespace DesignPattern.Creational_Patterns
{
    /// <summary>
    ///     Abstract Factory :
    ///     Provide an interface for creating families of related or dependent objects without
    ///     specifying their concrete classes
    /// </summary>
    public class AbstractFactory
    {
        public enum DBSkillSet
        {
            MSSQL,
            MySQL
        }

        public enum UISkillSet
        {
            DotNet,
            Java
        }

        /// <summary>
        ///     Entry point into console application.
        /// </summary>
        public void Execute()
        {
            Console.WriteLine("================== Start Abstract Factory ======================");
            IBaseFactory baseFactory = new ProjectA(UISkillSet.DotNet, DBSkillSet.MSSQL);
            Console.WriteLine(baseFactory.GetUITeam().GetTeam());
            Console.WriteLine("================== End Abstract Factory   ======================");

        }

        public interface IBaseFactory
        {
            ITeamFactory GetUITeam();
            ITeamFactory GetDBTeam();
        }

        public interface ITeamFactory
        {
            string GetTeam();
        }

        public class ProjectA : IBaseFactory
        {
            private readonly DBSkillSet DBSkillSet;
            private readonly UISkillSet UISkillSet;

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
}