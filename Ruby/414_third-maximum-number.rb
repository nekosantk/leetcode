# @param {Integer[]} nums
# @return {Integer}
def third_max(nums)
    nums = nums.uniq.sort.reverse
    size = nums.size
    return size <= 2 ? nums[0] : nums[2]
end