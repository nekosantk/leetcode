# @param {Integer} x
# @return {Integer}
def reverse(x)
    result = x.to_s.reverse.to_i
    if result > 2**31 - 1 || result < -2**31
        result = 0
    end
    if x < 0
        result *= -1
    end
    return result;
end