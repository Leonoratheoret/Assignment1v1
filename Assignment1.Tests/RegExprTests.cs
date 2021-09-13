using Xunit;
using System.Collections.Generic;

namespace Assignment1.Tests
{
    public class RegExprTests
    {
        [Fact]
        public void given_list_of_lines_containing_words_return_each_word_seperately()
        {
            var strings = new string[] {"hej med dig", "i dag er det en god dag", "csharp er sjovt 100"}; 
            var output = RegExpr.SplitLine(strings);
            var actual = new string[]{"hej", "med", "dig", "i", "dag", "er", "det", "en", "god", "dag",
                                        "csharp", "er", "sjovt", "100"};
            Assert.Equal(actual, output);
        }

        [Fact]
        public void given_list_of_resolutions_return_resolution_as_tuples()
        {
        
            var input = new string[]{"1920x1080", "1024x768, 800x600, 640x480", "320x200, 320x240, 800x600", "1280x960"};
            var actual = RegExpr.Resolution(input);
            var expected = new (int, int)[]{(1920, 1080), (1024, 768), (800, 600),
                                        (640, 480), (320, 200), (320, 240), (800, 600), (1280, 960)};

            Assert.Equal(expected, actual);
        }
        

    }
}
