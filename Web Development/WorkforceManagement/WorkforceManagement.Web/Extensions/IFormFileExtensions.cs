namespace WorkforceManagement.Web.Helpers;
public static class IFormFileExtensions
{
    public static string SaveImage(this IFormFile profileImage)
    {
        // Save profile image to some location
        var fileName = profileImage.FileName;   
        var uniqueFileName = $"{Guid.NewGuid()}_{fileName}"; //38b7feaa-39d3-4ead-aeeb-ee7dff72cd4a_person.jpg
        var relativePath = $"/images/profiles/{uniqueFileName}";
        var currentAppPath = Directory.GetCurrentDirectory();
        var fullFilePath = Path.Combine(currentAppPath, $"wwwroot/{relativePath}");

        using var stream = File.Create(fullFilePath);
        profileImage.CopyTo(stream);

        // Return relative path to save to db
        return relativePath;
    }
}
