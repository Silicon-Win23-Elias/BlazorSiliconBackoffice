﻿namespace BlazorSiliconBackoffice.Data;

public class UserCourses
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string UserId { get; set; } = null!;
    public string CourseId { get; set; } = null!;
}
