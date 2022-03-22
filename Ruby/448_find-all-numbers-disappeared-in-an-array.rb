# @param {Integer[]} nums
# @return {Integer[]}
def find_disappeared_numbers(nums)
    return (1..nums.size).to_a - nums
end