class Solution:
    def isValid(self, s: str) -> bool:
        stack = []
        for cur_char in s:
            if cur_char == "(" or cur_char == "[" or cur_char == "{":
                stack.append(cur_char)
            elif cur_char == ")" or cur_char == "]" or cur_char == "}":
                if len(stack) == 0:
                    return False
                popped_char = stack.pop()
                if cur_char == ")" and popped_char != "(":
                    return False
                elif cur_char == "]" and popped_char != "[":
                    return False
                elif cur_char == "}" and popped_char != "{":
                    return False
        if len(stack) == 0:
            return True
        return False
