class Solution:
    def longestCommonPrefix(self, strs: List[str]) -> str:
        prefix_stack = ""
        letter_index = 0
        while True:
            cur_char = ""
            for word in strs:
                if letter_index < len(word):
                    char_to_check = word[letter_index]
                    if cur_char == "":
                        cur_char = char_to_check
                    if char_to_check != cur_char:
                        return prefix_stack
                else:
                    return prefix_stack
            prefix_stack = prefix_stack + cur_char
            cur_char = ""
            letter_index = letter_index + 1
        return prefix_stack