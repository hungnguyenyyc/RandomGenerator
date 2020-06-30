using System;
using System.Collections.Generic;
using Xunit;

namespace RandomGenerator.Tests
{
    public class RandomGeneratorTests
    {

        private readonly RandomGenerator _generator;

        public RandomGeneratorTests() {
            _generator = new RandomGenerator(); 
        }

        [Fact]
        public void Should_generate_10000_random_numbers_inclusive()
        {
            List<int> nums = new List<int>(_generator.Generate());

            // other assertion can be done is to create another list and check these 2 lists again each other
            // but this way can introduce false negatives
            Assert.Equal(10000, nums.Count); // size check
            Assert.Contains(nums, i => i == 1); // inclusive check
            Assert.Contains(nums, i => i == 10000); // inclusive check
        }
    }
}
