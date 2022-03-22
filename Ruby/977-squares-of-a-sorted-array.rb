# @param {Integer[]} nums
# @return {Integer[]}
def sorted_squares(nums)
    return (nums.map{ |num| num *= num}).sort
end