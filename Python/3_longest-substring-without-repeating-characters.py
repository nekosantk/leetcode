class Solution:
    def lengthOfLongestSubstring(self, s: str) -> int:
        stack = []
        max_length = 0
        for x in range(len(s)):
            cur_char = s[x]
            if cur_char not in stack:
                stack.append(cur_char)
                cur_length = len(stack)
                if cur_length > max_length:
                    max_length = cur_length
            else:
                start_removal_index = stack.index(cur_char)
                if start_removal_index == 0:
                    del stack[0]
                else:  
                    stack = [v for i, v in enumerate(stack) if i not in range(0, start_removal_index + 1)]
                stack.append(cur_char)

        return max_length