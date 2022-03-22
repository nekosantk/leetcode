class Solution:
    def myAtoi(self, s: str) -> int:
        s = s.strip()
        if (len(s) == 0) or (len(s) == 1 and not s[0].isdigit()) or (s[0] != '-' and s[0] != '+' and not s[0].isdigit()) or ((s[0] == '+' or s[0] == '-') and not s[1].isdigit()):
            return 0

        has_found_num = False
        result = ""
        signed_op = 1
        for index in range(0, len(s)):
            if not has_found_num and s[index].isdigit():
                has_found_num = True
                if index > 0 and s[index - 1] == '-':
                    signed_op = -1
            if has_found_num:
                if s[index].isdigit() or s[index] == '.' or s[index] == ',':
                    result = result + s[index]
                else:
                    break
        result = math.floor(float(result)) * signed_op
        max = int(math.pow(2, 31))
        min = max * -1
        if result >= max:
            result = max - 1
        if result < min:
            result = min

        return result