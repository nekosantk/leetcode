class Solution:
    def findMedianSortedArrays(self, nums1: List[int], nums2: List[int]) -> float:
        result = []
        for num in nums1:
            result.append(num)
        for num in nums2:
            result.append(num)
        result.sort()
        if len(result) % 2 == 0:
            return (result[int(len(result) / 2) - 1] + result[(int(len(result) / 2))]) / 2
        return result[int(len(result) / 2)]