using DDDSampleProject.Domain.Primitives;
using DDDSampleProject.Domain.ValueObjects;

namespace DDDSampleProject.Domain.Entities.CourseManagement;

public class Lesson:BaseEntity
{
    #region Constructor

    internal Lesson(BaseId id, Title title, VideoUrl videoUrl, BaseId courseCatalogId) : base(id)
    {
        _title = title;
        _videoUrl = videoUrl;
        _courseCatalogId = courseCatalogId;
    }

    public Lesson(BaseId id):base(id)
    {
        
    }
    #endregion

    private Title _title;
    private VideoUrl _videoUrl;
    private BaseId _courseCatalogId;
    public string Title { get; set; }
    public string VideoUrl { get; set; }
}
