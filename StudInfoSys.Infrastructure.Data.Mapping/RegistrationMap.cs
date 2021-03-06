using StudInfoSys.Core.Models;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace StudInfoSys.Infratructure.Data.Mapping
{
    public class RegistrationMap : EntityTypeConfiguration<Registration>
    {
        public RegistrationMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

			// TODO: create unique index/constraint for all columns in the next line
			// ref. http://stackoverflow.com/questions/1174469/should-i-use-a-composite-key-for-a-map-table-which-is-also-used-for-a-foreign-k
			//this.HasKey(t => new { t.SchoolYearFrom, t.SchoolYearTo, t.Semester, t.DegreeId, t.StudentId });

            // Relationships
            this.HasRequired(t => t.Student)
                .WithMany(t => t.Registrations)
                .HasForeignKey(d => d.StudentId);
        }
    }
}
