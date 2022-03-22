class Solution:
    def romanToInt(self, s: str) -> int:
        total = 0
        i = 0
        while i < len(s):
            if s[i] == 'I':
                if i + 1 < len(s) and s[i + 1] == 'V':
                    total = total + 4
                    i = i + 2
                elif i + 1 < len(s) and s[i + 1] == 'X':
                    total = total + 9
                    i = i + 2
                else:
                    total = total + 1
                    i = i + 1
            elif s[i] == 'V':
                total = total + 5
                i = i + 1
            elif s[i] == 'X':
                if i + 1 < len(s) and s[i + 1] == 'L':
                    total = total + 40
                    i = i + 2
                elif i + 1 < len(s) and s[i + 1] == 'C':
                    total = total + 90
                    i = i + 2
                else:
                    total = total + 10
                    i = i + 1
            elif s[i] == 'L':
                total = total + 50
                i = i + 1
            elif s[i] == 'C':
                if i + 1 < len(s) and s[i + 1] == 'D':
                    total = total + 400
                    i = i + 2
                elif i + 1 < len(s) and s[i + 1] == 'M':
                    total = total + 900
                    i = i + 2
                else:
                    total = total + 100
                    i = i + 1
            elif s[i] == 'D':
                total = total + 500
                i = i + 1
            elif s[i] == 'M':
                total = total + 1000
                i = i + 1
            else:
                i = i + 1

        return total
