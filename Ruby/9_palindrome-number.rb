# @param {Integer} x
# @return {Boolean}
def is_palindrome(x)
    return x.to_s.reverse == x.to_s
end