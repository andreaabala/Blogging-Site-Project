using AbalaLE2_new.Models;

namespace AbalaLE2_new.Data
{
    public interface ISqlData
    {
        void AddPost(PostModel post);
        UserModel Authenticate(string username, string password);
        List<ListPostModel> ListPosts();
        void Register(string username, string password, string firstName, string lastName);
        ListPostModel ShowPostDetails(int id);
    }
}