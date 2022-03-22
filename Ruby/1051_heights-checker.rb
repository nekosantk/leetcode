# @param {Integer[]} heights
# @return {Integer}
def height_checker(heights)
    sorted_heights = heights.sort
    count = 0
    i = 0
    size = heights.size
    while i < size
        count += 1 unless heights[i] == sorted_heights[i]
        i += 1
    end
    return count
end