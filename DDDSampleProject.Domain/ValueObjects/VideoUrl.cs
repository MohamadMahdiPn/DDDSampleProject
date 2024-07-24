using DDDSampleProject.Domain.Exceptions.CourseManagementExceptions;

namespace DDDSampleProject.Domain.ValueObjects;

public record VideoUrl
{
    #region Constructor
    public VideoUrl(string value)
    {
        if (string.IsNullOrEmpty(value))
            throw new VideoUrlNullOrEmptyException();
        if (value.Length > 300)
            throw new InvalidVideoUrlLengthException();
        if (!value.EndsWith(".mp4"))
            throw new InvalidVideoUrlExtentionException();
        Value = value;
    }
    #endregion

    public string Value { get; }





    public static implicit operator string(VideoUrl value) => value.Value;
    public static implicit operator VideoUrl(string value) => new VideoUrl(value);
}