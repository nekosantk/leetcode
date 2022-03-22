# @param {Integer[]} nums
# @param {Integer} target
# @return {Integer[]}
def two_sum(nums, target)
    checked = {}
    nums.each_with_index do |value, i|
        diff = target - value

        if (checked[diff])
            return [checked[diff], i]
        else
            checked[value] = i
        end
    end
end