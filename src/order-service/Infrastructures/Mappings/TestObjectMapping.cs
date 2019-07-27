using FluentNHibernate.Mapping;
using orderService.Domains;

namespace orderService.Infrastructures.Mappings
{
    public class TestObjectMapping : ClassMap<TestObject>
    {
        public TestObjectMapping()
        {
            Table("test_object");
            Id(x => x.Id).GeneratedBy.Native();
            Map(x => x.Name);
        }
    }
}