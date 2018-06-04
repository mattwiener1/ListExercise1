using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
//            1 - When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.
//
//                If no one likes your post, it doesn't display anything.
//                If only one person likes your post, it displays: [Friend's Name] likes your post.
//                If two people like your post, it displays: [Friend 1] and[Friend 2] like your post.
//                If more than two people like your post, it displays: [Friend 1], [Friend 2] and[Number of Other People] others like your post.
//                Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name).
//                Depending on the number of names provided, display a message based on the above pattern.

            var list = new List<string>();
            while (true)
            {
                Console.WriteLine("Please write a name to use for a like on this post: ");

                var add = Console.ReadLine();
                if (add == "")
                {
                    break;
                }

                list.Add(add);
            }

            if (list.Count == 0)
                Console.WriteLine("Sorry, no one liked your post");
            if (list.Count == 1)
                Console.WriteLine(list[0] + " Liked your post!!");
            if (list.Count == 2)
                Console.WriteLine(list[0] + " & " + list[1] + " liked your post!!");
            if (list.Count > 2)
            {
                var remainder = list.Count - 2;
                var pronoun = "person";
                if (remainder > 1)
                    pronoun = "people";
                Console.WriteLine(list[0] + ", " + list[1] + ", and " + remainder + " other " + pronoun + " liked your post!!" );
            }
                
        }
    }
}
