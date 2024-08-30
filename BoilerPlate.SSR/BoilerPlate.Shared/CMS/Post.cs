using BoilerPlate.Shared.Users;

namespace BoilerPlate.Shared.CMS;

public class Post : IContent
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string Description { get; set; }
    public string? UrlName { get; set; }
    public string? Content { get; set; }
    public string? ContentHtml { get; set; }
    
    public DateTimeOffset PublishDate { get; set; }
    public DateTimeOffset ModifiedDate { get; set; }
    
    public ApplicationUser Author { get; set; }
    public string AuthorId { get; set; }
    public PostTypeEnum PostType { get; set; }
    
    public Post? ParentPost { get; set; }
    public Post[] ChildrenPosts { get; set; }
    
    
    public Taxonomy[] Taxonomies { get; set; }
    
}